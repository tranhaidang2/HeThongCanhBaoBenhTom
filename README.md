"# HeThongCanhBaoBenhTom"
HeThongCanhBaoBenhTom/  
│  
├── wwwroot/                  # File tĩnh (CSS, JS, hình ảnh)  
│   ├── css/  
│   ├── js/  
│   └── images/  
│  
├── Controllers/              # Bộ điều khiển  
│   ├── TrangChuController.cs  
│   ├── BenhTomController.cs  # Quản lý bệnh tôm  
│   └── DuBaoController.cs    # Xử lý dự báo  
│  
├── Models/                   # Mô hình dữ liệu  
│   ├── BenhTom.cs            # Thông tin bệnh  
│   ├── DuBao.cs              # Mô hình dự báo  
│   └── ViewModels/           # Dữ liệu hiển thị  
│  
├── Services/                 # Dịch vụ xử lý  
│   ├── BenhTomService.cs     # Logic nghiệp vụ  
│   └── DuBaoService.cs       # Xử lý dự báo  
│  
├── Data/                     # Cơ sở dữ liệu  
│   ├── DatabaseContext.cs  
│   └── Migrations/  
│  
└── Views/                    # Giao diện  
    ├── TrangChu/             # Trang chủ  
    ├── BenhTom/              # Hiển thị bệnh  
    └── DuBao/                # Trang dự báo  
  
 
