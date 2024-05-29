## File 1: Pizza 
* Tạo các Models
* Tạo PizzaContext - Kết nối với SQLServer bằng cách override void OnConfiguring
* Thử thay đổi/tạo mới/truy vấn/xoá các entity trong Database từ code (trong "Program.cs")

## File 2: Pizza2
* Tạo sẵn một database trong SQLServer và populate các data
* Sau đó dùng lệnh 'dotnet ef dbcontext scaffold' để connect với database sẵn có => tạo các file Models và Data trong folder project Pizza2

## File 3: PizzaWeb 
* Tạo một trang web bằng ASP.NET Core Razor
* Connect với database sẵn có giống File 2 "Pizza2"
* Dùng package Microsoft.VisualStudio.Web.CodeGeneration.Design và tool dotnet-aspnet-codegenerator để tạo các trang Razor CRUD (delete, update, post, get)

  <img width="1512" alt="Screenshot 2024-05-29 at 3 50 15 PM" src="https://github.com/haianhng31/ef-core-practice/assets/126405175/6262f78b-0396-45ea-8b88-9b0587929952">
<img width="1512" alt="Screenshot 2024-05-29 at 3 51 21 PM" src="https://github.com/haianhng31/ef-core-practice/assets/126405175/bf5ab9f7-086b-473b-b963-1bfe92f4b856">
<img width="1512" alt="Screenshot 2024-05-29 at 3 51 15 PM" src="https://github.com/haianhng31/ef-core-practice/assets/126405175/414ad633-2ee2-492d-bf31-525150f169a9">
<img width="1512" alt="Screenshot 2024-05-29 at 3 51 08 PM" src="https://github.com/haianhng31/ef-core-practice/assets/126405175/1ee57459-285b-40be-b357-904d176b7720">
<img width="1512" alt="Screenshot 2024-05-29 at 3 50 59 PM" src="https://github.com/haianhng31/ef-core-practice/assets/126405175/e5584a1f-0e42-4acb-9c83-40be8812f542">
<img width="1512" alt="Screenshot 2024-05-29 at 3 50 52 PM" src="https://github.com/haianhng31/ef-core-practice/assets/126405175/10555167-6eb1-4f24-841d-c6d830b911db">
