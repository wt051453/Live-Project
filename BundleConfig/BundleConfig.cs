
// Copy the showCalendar() method from employeeindex.js into a newly created script file calendar.js and added it to the BundleConfig.cs

bundles.Add(new ScriptBundle("~/bundles/fullcalendar").Include(
					  "~/Scripts/moment.min.js",
					  "~/Scripts/fullcalendar/fullcalendar.min.js",
					  "~/Scripts/calendar.js"));

