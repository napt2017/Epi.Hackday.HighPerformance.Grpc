## 1. Create new empty Asp.NET Core App
## 2 . Add dependency 
```xml
<ItemGroup>
    <PackageReference Include="SoapCore" Version="1.1.0.2" />
</ItemGroup>
```

## 3. Add service contract in `Interfaces` folder named IHackdayTopicOperation
```csharp
using DB.Access.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace SOAP.Server.Interfaces
{
    [ServiceContract]
    public interface IHackdayTopicOperation
    {
        [OperationContract]
        List<HackdayTopic> GetAllHackdayTopic();
    }
}

```

## 4. Add implementation for it
```csharp
using DB.Access.Entities;
using DB.Access.Repositories;
using SOAP.Server.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SOAP.Server.HackdayTopicOperation
{
    public class HackdayTopicOperation : IHackdayTopicOperation
    {
        private readonly IEpiHackdayRepository _epiHackdayRepository;

        public HackdayTopicOperation(IEpiHackdayRepository epiHackdayRepository)
        {
            _epiHackdayRepository = epiHackdayRepository;
        }

        public List<HackdayTopic> GetAllHackdayTopic()
        {
            return _epiHackdayRepository.GetAll().ToList();
        }
    }
}

```

## 5.Modify `startup.cs` file
```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddSoapCore();
    services.AddDbContext<EpiHackdayDbContext>(options => options.UseSqlite(@"Data Source=C:\Users\TheCodeNameOne\Desktop\hackday.db"));
    services.AddScoped<IEpiHackdayRepository, EpiHackdayRepository>();
    services.AddScoped<IHackdayTopicOperation, SOAP.Server.HackdayTopicOperation.HackdayTopicOperation>();
}

```

```csharp
public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{ 
    //....
    app.UseSoapEndpoint<IHackdayTopicOperation>("/HackdayTopic.svc", new BasicHttpBinding(), SoapSerializer.XmlSerializer);
}
```