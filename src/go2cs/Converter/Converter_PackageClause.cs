﻿//******************************************************************************************************
//  Converter_PackageClause.cs - Gbtc
//
//  Copyright © 2018, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the MIT License (MIT), the "License"; you may not use this
//  file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://opensource.org/licenses/MIT
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  05/03/2018 - J. Ritchie Carroll
//       Generated original version of source code.
//
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static go2cs.Common;

namespace go2cs;

public partial class Converter
{
    public string PackageUsing { get; private set; }

    public string PackageNamespace { get; private set; }

    public string[] PackageNamespaces { get; private set; }

    private string m_packageLevelComments;
    private string m_namespaceHeader;
    private string m_namespaceFooter;
    private string m_namespaceHeaderLegacy;
    private string m_namespaceFooterLegacy;

    public override void EnterPackageClause(GoParser.PackageClauseContext context)
    {
        base.EnterPackageClause(context);

        // Go package clause is the first keyword encountered - cache details that
        // will be written out after imports. C# import statements (i.e., usings)
        // must occur before class definitions.
        string[] paths = PackageImport.Split('/').Select(SanitizedIdentifier).ToArray();
        string packageNamespace = $"{RootNamespace}.{string.Join(".", paths)}";

        PackageUsing = $"{Package} = {packageNamespace}{ClassSuffix}";
        PackageNamespace = packageNamespace[..packageNamespace.LastIndexOf('.')];

        // Track file name associated with package
        AddFileToPackage(Package, TargetFileName, PackageNamespace);

        // Define namespaces
        List<string> packageNamespaces = new() { RootNamespace };

        if (paths.Length > 1)
        {
            packageNamespaces.AddRange(paths);
            packageNamespaces.RemoveAt(packageNamespaces.Count - 1);
        }

        PackageNamespaces = packageNamespaces.ToArray();

        string headerLevelComments = CheckForCommentsLeft(context);
        m_packageLevelComments = CheckForCommentsRight(context);

        if (!string.IsNullOrWhiteSpace(headerLevelComments))
        {
            if (m_targetFile.Length == 0)
                headerLevelComments = headerLevelComments.TrimStart();

            m_targetFile.Append(headerLevelComments);

            if (!EndsWithLineFeed(headerLevelComments))
                m_targetFile.AppendLine();

            if (!Options.ExcludeHeaderComments && !EndsWithDuplicateLineFeed(m_targetFile.ToString()))
                m_targetFile.AppendLine();
        }

        if (!Options.ExcludeHeaderComments)
        {
            m_targetFile.AppendLine($"// package {Package} -- go2cs converted at {DateTime.UtcNow:yyyy MMMM dd HH:mm:ss} UTC");

            if (!PackageImport.Equals("main"))
                m_targetFile.AppendLine($"// import \"{PackageImport}\" ==> using {PackageUsing}");

            m_targetFile.AppendLine($"// Original source: {SourceFileName}");
        }

        // Begin namespaces
        StringBuilder namespaceHeader = new();

        for (int i = 0; i < PackageNamespaces.Length; i++)
        {
            namespaceHeader.Append($"namespace {PackageNamespaces[i]}");
            namespaceHeader.Append(i == PackageNamespaces.Length - 1 ? $"{Environment.NewLine}{{" : $" {{{Environment.NewLine}");
        }

        m_namespaceHeaderLegacy = namespaceHeader.ToString();
        m_namespaceFooterLegacy = new('}', PackageNamespaces.Length);

        if (Options.WriteLegacyCompatibleCode)
        {
            m_namespaceHeader = m_namespaceHeaderLegacy;
            m_namespaceFooter = m_namespaceFooterLegacy;
        }
        else
        {
            namespaceHeader = new("namespace ");

            for (int i = 0; i < PackageNamespaces.Length; i++)
            {
                if (i > 0)
                    namespaceHeader.Append('.');

                namespaceHeader.Append($"{PackageNamespaces[i]}");
            }

            namespaceHeader.AppendLine(";");

            m_namespaceHeader = namespaceHeader.ToString();
            m_namespaceFooter = string.Empty;
        }

        m_targetFile.Append(m_namespaceHeader);

        // Add commonly required using statements
        if (Options.WriteLegacyCompatibleCode)
            RequiredUsings.Add("static go.builtin");
    }
}
