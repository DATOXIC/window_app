## Dùng chung database cho cả team (SQL Server)

App hiện **không dùng LocalDB** nữa. Mỗi máy dev sẽ kết nối tới **một SQL Server chung** bằng biến môi trường `WINDOW_APP_SQL_CONNECTION`.

### 1) Setup SQL Server trên 1 máy trong team (máy Server)
- Cài **SQL Server Express** (miễn phí) hoặc Developer + **SSMS**
- Bật TCP/IP
  - Mở **SQL Server Configuration Manager**
  - `SQL Server Network Configuration` → `Protocols for <instance>` → bật **TCP/IP**
  - Restart service SQL Server
- Mở firewall (Windows Defender Firewall) cho port SQL Server (thường `1433`)
- Tạo database, ví dụ: `window_app`
- Tạo SQL Login cho app, ví dụ: `window_app_user`
  - Grant quyền tối thiểu: db_datareader + db_datawriter (demo/đồ án)

### 2) Tạo schema
Chạy file:
- `database/schema.sql`

### 3) Cấu hình trên mỗi máy dev (Client)
Set biến môi trường (PowerShell):

```powershell
[Environment]::SetEnvironmentVariable(
  "WINDOW_APP_SQL_CONNECTION",
  "Server=<IP_or_HOST>\\SQLEXPRESS;Database=window_app;User Id=window_app_user;Password=<PASSWORD>;TrustServerCertificate=True;Connection Timeout=30;",
  "User"
)
```

Nếu server dùng instance mặc định:

```powershell
[Environment]::SetEnvironmentVariable(
  "WINDOW_APP_SQL_CONNECTION",
  "Server=<IP_or_HOST>;Database=window_app;User Id=window_app_user;Password=<PASSWORD>;TrustServerCertificate=True;Connection Timeout=30;",
  "User"
)
```

Sau khi set xong, **đóng app** và mở lại (hoặc restart Visual Studio) để lấy env var mới.

### 4) Kiểm tra kết nối nhanh
- Ping được máy server (cùng mạng)
- Port `1433` không bị chặn
- Đúng instance name (`SQLEXPRESS`) hoặc đúng port

### Lỗi hay gặp
- **Login failed**: sai user/password hoặc chưa bật SQL Authentication mode
- **Network-related or instance-specific error**: chưa bật TCP/IP, chưa mở firewall, sai hostname/instance
- **Certificate/SSL error**: với máy server nội bộ, để nhanh có thể dùng `TrustServerCertificate=True`

