HƯỚNG DẪN CHẠY

1. Cài PostgreSQL + pgAdmin.
2. Tạo database:
   book_management

3. Sửa mật khẩu PostgreSQL trong appsettings.json

4. Mở Terminal tại thư mục project:

dotnet restore

dotnet tool install --global dotnet-ef

dotnet ef migrations add InitialCreate

dotnet ef database update

5. Chạy:

dotnet run

Mở:
https://localhost:xxxx/Books