Open the project using Visual Studio and run it directly. The http://localhost:5078/test/getcustomers page will open directly, and there are also http://localhost:5078/test/getmanagers pages that can be accessed.

Currently, the loop problem is solved through [JsonIgnore], so a layer of Managers can be obtained from Customers, but Customers cannot be obtained through Managers.

If I delete [JsonIgnore] from TestItem, there will be a looping problem.