// Copyright 2019 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package export -- go2cs converted at 2022 March 06 23:31:37 UTC
// import "golang.org/x/tools/internal/event/export" ==> using export = go.golang.org.x.tools.@internal.@event.export_package
// Original source: C:\Users\ritchie\go\src\golang.org\x\tools\internal\event\export\log.go
using context = go.context_package;
using fmt = go.fmt_package;
using io = go.io_package;
using sync = go.sync_package;

using @event = go.golang.org.x.tools.@internal.@event_package;
using core = go.golang.org.x.tools.@internal.@event.core_package;
using label = go.golang.org.x.tools.@internal.@event.label_package;

namespace go.golang.org.x.tools.@internal.@event;

public static partial class export_package {

    // LogWriter returns an Exporter that logs events to the supplied writer.
    // If onlyErrors is true it does not log any event that did not have an
    // associated error.
    // It ignores all telemetry other than log events.
public static event.Exporter LogWriter(io.Writer w, bool onlyErrors) {
    ptr<logWriter> lw = addr(new logWriter(writer:w,onlyErrors:onlyErrors));
    return lw.ProcessEvent;
}

private partial struct logWriter {
    public sync.Mutex mu;
    public Printer printer;
    public io.Writer writer;
    public bool onlyErrors;
}

private static context.Context ProcessEvent(this ptr<logWriter> _addr_w, context.Context ctx, core.Event ev, label.Map lm) => func((defer, _, _) => {
    ref logWriter w = ref _addr_w.val;


    if (@event.IsLog(ev)) 
        if (w.onlyErrors && !@event.IsError(ev)) {
            return ctx;
        }
        w.mu.Lock();
        defer(w.mu.Unlock());
        w.printer.WriteEvent(w.writer, ev, lm);
    else if (@event.IsStart(ev)) 
        {
            var span__prev1 = span;

            var span = GetSpan(ctx);

            if (span != null) {
                fmt.Fprintf(w.writer, "start: %v %v", span.Name, span.ID);
                if (span.ParentID.IsValid()) {
                    fmt.Fprintf(w.writer, "[%v]", span.ParentID);
                }
            }

            span = span__prev1;

        }

    else if (@event.IsEnd(ev)) 
        {
            var span__prev1 = span;

            span = GetSpan(ctx);

            if (span != null) {
                fmt.Fprintf(w.writer, "finish: %v %v", span.Name, span.ID);
            }

            span = span__prev1;

        }

        return ctx;

});

} // end export_package
