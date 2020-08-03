﻿//******************************************************************************************************
//  Converter_Statement.cs - Gbtc
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
//  05/04/2018 - J. Ritchie Carroll
//       Generated original version of source code.
//
//******************************************************************************************************

using go2cs.Metadata;
using System;
using System.Text;
using static go2cs.Common;

namespace go2cs
{
    public partial class Converter
    {
        private bool TryGetFunctionVariable(string identifier, out VariableInfo variable)
        {
            variable = default;
            return m_inFunction && (m_currentFunction?.Variables?.TryGetValue(identifier, out variable) ?? false) && !(variable is null);
        }

        private string OpenRedeclaredVariableBlock(GoParser.ShortVarDeclContext context, int level)
        {
            GoParser.IdentifierListContext identifierList = context.identifierList();

            if (!Identifiers.TryGetValue(identifierList, out string[] identifiers))
            {
                // Pre-visit identifiers if they are not defined yet
                EnterIdentifierList(identifierList);
                
                if (!Identifiers.TryGetValue(identifierList, out identifiers))
                {
                    AddWarning(context, $"Failed to find identifier lists needed to hold and restore values for short var declaration statements: {context.GetText()}");
                    return "";
                }
            }

            StringBuilder block = new StringBuilder();
            bool addNewLine = false;

            foreach (string identifier in identifiers)
            {
                if (TryGetFunctionVariable(identifier, out VariableInfo variable) && variable.Redeclared)
                {
                    addNewLine = true;
                    block.Append($"{Spacing()}{variable.Type.TypeName ?? "var"} {identifier}__prev{level} = {identifier};{Environment.NewLine}");
                }
            }

            if (addNewLine)
                block.AppendLine();

            return block.ToString();
        }

        private string CloseRedeclaredVariableBlock(GoParser.ShortVarDeclContext context, int level)
        {
            StringBuilder block = new StringBuilder();

            GoParser.IdentifierListContext identifierList = context.identifierList();

            if (Identifiers.TryGetValue(identifierList, out string[] identifiers))
            {
                bool addNewLine = false;

                foreach (string identifier in identifiers)
                {
                    if (TryGetFunctionVariable(identifier, out VariableInfo variable) && variable.Redeclared)
                    {
                        addNewLine = true;
                        block.Append($"{Spacing()}{identifier} = {identifier}__prev{level};{Environment.NewLine}");
                    }
                }

                if (addNewLine)
                    block.Insert(0, $"{Environment.NewLine}");
            }
            else
            {
                AddWarning(context, $"Failed to find identifier lists needed to stack creation for short var declaration statement: {context.GetText()}");
            }

            return block.ToString();
        }

        public override void ExitShortVarDecl(GoParser.ShortVarDeclContext context)
        {
            // shortVarDecl
            //     : identifierList ':=' expressionList

            GoParser.IdentifierListContext identifierList = context.identifierList();

            if (Identifiers.TryGetValue(identifierList, out string[] identifiers) && ExpressionLists.TryGetValue(context.expressionList(), out ExpressionInfo[] expressions))
            {
                StringBuilder statement = new StringBuilder();

                if (identifiers.Length != expressions.Length)
                {
                    if (identifiers.Length > expressions.Length && expressions.Length == 1)
                        identifiers = new[] { $"({string.Join(", ", identifiers)})" };
                    else
                        AddWarning(context, $"Encountered count mismatch for identifiers and expressions in short var declaration statement: {context.GetText()}");
                }

                for (int i = 0; i < identifiers.Length; i++)
                {
                    if (expressions.Length > i)
                        m_variables.Add(identifierList.IDENTIFIER(i), GetUniqueIdentifier(m_variables, identifiers[i]));
                }

                int length = Math.Min(identifiers.Length, expressions.Length);

                for (int i = 0; i < length; i++)
                {
                    bool isInitialDeclaration = true;

                    // Determine if this is the initial declaration
                    if (m_inFunction && m_variables.TryGetValue(identifierList.IDENTIFIER(i), out string variableName))
                        isInitialDeclaration = !variableName.Contains("@@");

                    statement.Append($"{Spacing()}{(isInitialDeclaration ? $"{expressions[i].Type?.TypeName ?? "var"} " : "")}{SanitizedIdentifier(identifiers[i])} = {expressions[i]};");

                    // Since multiple declarations can be on one line, only check for comments after last declaration
                    if (i < length - 1)
                    {
                        statement.AppendLine();
                    }
                    else
                    {
                        statement.Append(CheckForCommentsRight(context));

                        if (!WroteLineFeed)
                            statement.AppendLine();
                    }
                }

                m_simpleStatements[context.Parent] = statement.ToString();
            }
            else
            {
                AddWarning(context, $"Failed to find both identifier and expression lists for short var declaration statement: {context.GetText()}");
            }
        }
    }
}
