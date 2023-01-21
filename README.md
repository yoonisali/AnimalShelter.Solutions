# _Animal Shelter_

#### By: _**Yoonis Ali**_

## _Technologies Used_

* _C#_
* _.NET 6_
* _ASP.NET Core MVC 6_
* _Entity Framework Core_
* _MVC_
* _HTML_
* _CSS_
* _CORS_
* _Swagger_ 

## _Description_

_An animal shelter web api application that allows the user to Create, Read, Update and/or Delete stored information about different dogs and cats that are in the animal shelter._

## Setup/Installation Requirements
* _Clone the repository to your desktop from: https://github.com/yoonisali/AnimalShelter.Solutions_

* _Create two files inside the AnimalShelterApi directory: `appsettings.json` and `appsettings.Development.json`._

* _Fill in `appsettings.json` with the following code:_

`{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[DB-NAME-HERE];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}`

* _Fill in `appsettings.Development.json` with the following code:_

`{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Trace",
      "Microsoft.AspNetCore": "Information",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "Jwt": {
    "Issuer": "http://localhost:5000",
    "Audience": "http://localhost:5000",
    "Key": "2754aa05-9e81-44a3-83da-50f819c07563"
  }
}`

* _Run `dotnet ef migrations add Initial` inside of the AnimalShelterApi directory._

* _Run `dotnet ef database update` inside of the AnimalShelterApi directory._

* _Run `dotnet build` inside of the AnimalShelterApi directory._

* _Run `dotnet watch run` inside of the AnimalShelterApi directory to run the program in the browser with a watcher and Swagger UI._

## _Endpoints_

_Base URL: https://localhost:5000_

### _HTTP Request Structure_

`GET /api/{component}
PUT /api/{component}
DELETE /api/{component}/{id}
GET /api/{component}/{id}
POST /api/{component}/{id}`

### _Example Query_

_`https://localhost:5001/api/Dogs/1`_

### _Sample JSON Response_

`{
  "dogId": 1,
  "name": "Dogzilla",
  "breed": "Central Asian Shepherd Dog",
  "age": 6
}`

### _Example Query_

_`https://localhost:5001/api/Cats/1`_

### _Sample JSON Response_

`{
  "catId": 1,
  "name": "Kit-Kat",
  "breed": "Savannah",
  "age": 4
}`





## Known Bugs

* _None_


## License

_Copyright (c) 2022 Yoonis Ali_

_Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:_

_The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software._

_THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE._
