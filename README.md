## File 1: Pizza 
* Tạo các Models
* Tạo PizzaContext - Kết nối với SQLServer bằng cách override void OnConfiguring
* Thử thay đổi/tạo mới/truy vấn/xoá các entity trong Database từ code (trong "Program.cs")
* Thể hiện 1-to-many hoặc many-to-many relationships bằng cách dùng IQueryable 

## File 2: Pizza2
* Tạo sẵn một database trong SQLServer và populate các data
* Sau đó dùng lệnh 'dotnet ef dbcontext scaffold' để connect với database sẵn có => tạo các file Models và Data trong folder project Pizza2

## File 3: PizzaWeb 
* Tạo một trang web bằng ASP.NET Core Razor
* Connect với database sẵn có giống File 2 "Pizza2"
* Dùng users-secret để store Connection String 
* Dùng package Microsoft.VisualStudio.Web.CodeGeneration.Design và tool dotnet-aspnet-codegenerator để tạo các trang Razor CRUD (delete, update, post, get)

<img width="1512" alt="Screenshot 2024-05-29 at 4 09 44 PM" src="https://github.com/haianhng31/ef-core-practice/assets/126405175/b2b69dff-9eb7-41d7-bfeb-b78a703e84be">
<img width="1512" alt="Screenshot 2024-05-29 at 4 09 41 PM" src="https://github.com/haianhng31/ef-core-practice/assets/126405175/5aa6d83a-35a1-4537-af15-8ce90aa32764">
<img width="1512" alt="Screenshot 2024-05-29 at 4 09 39 PM" src="https://github.com/haianhng31/ef-core-practice/assets/126405175/55d575b4-ff82-4f36-b962-fbdf10ddc250">
<img width="1512" alt="Screenshot 2024-05-29 at 4 09 35 PM" src="https://github.com/haianhng31/ef-core-practice/assets/126405175/4a048dbf-4c54-474f-aee2-b7c844a1117c">
<img width="1512" alt="Screenshot 2024-05-29 at 4 09 32 PM" src="https://github.com/haianhng31/ef-core-practice/assets/126405175/7e59f947-84a4-4ba6-b1da-71ec0a801719">
<img width="1512" alt="Screenshot 2024-05-29 at 4 09 27 PM" src="https://github.com/haianhng31/ef-core-practice/assets/126405175/21a71aaa-7d86-4ff1-bd8f-6bbdb2d2a088">
