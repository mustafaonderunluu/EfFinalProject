# EfFinalProject


Bu proje, Northwind veritabanına erişim sağlayan bir veritabanı erişim katmanıdır. Entity Framework kullanarak veritabanı işlemlerini gerçekleştirir.
# Genel Bakış
Bu proje, Northwind veritabanında bulunan ürünler, müşteriler ve kategoriler gibi varlık türlerine erişim sağlar. Entity Framework kullanılarak veritabanı işlemleri gerçekleştirilir. İş katmanı, veritabanı işlemlerini soyutlar ve iş mantığını uygular.

# Proje Yapısı

├── Business
│   ├── Concrete
│   │   └── ProductManager.cs
│   └── IProductService.cs
├── DataAccess
│   ├── Abstract
│   │   ├── IProductDal.cs
│   │   ├── ICustomerDal.cs
│   │   └── ICategoryDal.cs
│   ├── Concrete
│   │   └── EntityFramework
│   │       ├── EfProductDal.cs
│   │       ├── EfCustomerDal.cs
│   │       └── EfCategoryDal.cs
│   └── NorthwindContext.cs
├── Entities
│   └── Concrete
│       ├── Product.cs
│       ├── Customer.cs
│       └── Category.cs
└── ConsoleUI
    └── Program.cs

# Bağımlılıklar
Proje, .NET Core ve Entity Framework Core kullanılarak geliştirilmiştir. Bağımlılıkları yönetmek için NuGet paket yöneticisi kullanılabilir.


