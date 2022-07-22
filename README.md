# Pierre's Vendor & Order Tracker
![PierresLogo](/VendorOrder/wwwroot/img/pierre.png)

#### By _Joseph Jack_

## _Description_

Pierre's Vendor and Order tracker is an application that allows the user to add both vendors and their individual orders. Users can select a vendor and choose from the list of orders to see further details.

## _Logistics_

|                    |                 Minimum Product Features                           |
| ------------------ | -----------------------------------------------------------------  |
| :heavy_check_mark: | All orders are assigned to a specific vendor                       |
| :heavy_check_mark: | Description, price and date are all logged for each order          |
| :heavy_check_mark: | User can fill out form for orders that are saved into a static list|
| :heavy_check_mark: | User can select specific order to see further details              |
| :heavy_check_mark: | MVC routes follow RESTful conventions                              |


## _Setup/Installation Requirements_

1. Clone this projects repository into your local directory following [these](https://www.linode.com/docs/development/version-control/how-to-install-git-and-clone-a-github-repository/) instructions.

2. Open the local project folder with VS Code or an equivalent

3. Download [.NET Core](https://docs.microsoft.com/en-us/dotnet/core/install/windows?pivots=os-windows&tabs=net60) then enter the following command in the terminal to confirm installation.

`dotnet -- version`

4. Continue by entering the following in the command line:

`dotnet tool install -g`

5. Navigate to VendorOrder directory and run `$ dotnet run build` in your terminal.


* For testing navigate to VendorOrder.Tests and run `$ dotnet test` in your terminal.


## _Technology Used_

- C#
- .NET Core
- MSTest
- VSCode
- Html & CSS
## Known Bugs

* No known issues noticed at this time.


## Legal

MIT License

Copyright &copy; Joseph Jack 2022


Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

