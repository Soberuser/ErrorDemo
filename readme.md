Now：

You can download and run it. There are two interfaces that generate loops,[http://localhost:5078/test/getmanagers], [http://localhost:5078/test/getcustomers] and two normal interfaces[http://localhost:5078/test/getcustomersnow], [http://localhost:5078/test/getmanagersnow]. 



Before：

Open the project using Visual Studio and run it directly. The http://localhost:5078/test/getcustomers page will open directly, and there are also http://localhost:5078/test/getmanagers pages that can be accessed.

Currently, the loop problem is solved through [JsonIgnore], so a layer of Managers can be obtained from Customers, but Customers cannot be obtained through Managers.

If I delete [JsonIgnore] from TestItem, there will be a looping problem.

