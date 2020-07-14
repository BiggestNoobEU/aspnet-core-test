dotnet ef migrations add InitialCreate --project ../AspNetCoreTestDataAccess

dotnet ef database update --project ../AspNetCoreTestDataAccess

dotnet ef migrations add AddAddresses --project ../AspNetCoreTestDataAccess