# **Pupper API**

#### Authors: **_Mai Cook and Eric Settels_**
#### Used By: **_Jessica Hvozdovich and Christopher Huber_**
#### June 10, 2020

### Description

_This application serves as an introduction to building an API with C#/.NET Core. It expands on the [Pupper API](https://github.com/LonleyBuzzyBee/pupper.git) created by Mai Cook and Eric Settels with an MVC application._

### Instructions for use:
1. Open Terminal (macOS) or PowerShell (Windows)
2. To download the API project Directory to your desktop enter the following commands:
```
cd Desktop
git clone https://github.com/jhvozdovich/pupper-api.git
cd pupper (or the file name you created for the main Directory of the download)
```
3. To view the downloaded files, open them in a text editor or IDE of your choice.
* if you have VSCode for example, when your terminal is within the main project Directory you can open all of the files with the command:
```
code .
```
4. Create a file within the Pupper folder named appsettings.json.
5. Add the following code:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=pupper_;uid=root;pwd=YOURMYSQLPASSWORDHERE;"
  }
}
```
* Add your MySQL password and make any other changes needed if you have an alternative server, port, or uid selected. These are the default settings.
6. To download the MVC project Directory to your desktop enter the following commands:
```
cd Desktop
git clone https://github.com/jhvozdovich/pupper-mvc.git
cd pupper-mvc (or the file name you created for the main Directory of the download)
```
7. To view the downloaded files, open them in a text editor or IDE of your choice.
* if you have VSCode for example, when your terminal is within the main project Directory you can open all of the files with the command:
```
code .
```


#### If you need to install and configure MySQL:
1. Download the MySQL Community Server DMG file [here](https://dev.mysql.com/downloads/file/?id=484914) with the "No thanks, just start my download" link.
2. On the configuration page of the installer select the following options:
* Use legacy password encryption
* Set your password
3. Open the terminal and enter the command:
*'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile
4. Download the MySQL Workbench DMG file [here](https://dev.mysql.com/downloads/file/?id=484391)
5. Open Local Instance 3306 with the password you set.

#### To create a local version of the database:
1. Open a terminal within your code editor.
2. Within the open API directory, navigate to the Pupper folder with the following command:
```
cd Pupper
```
3. Run the following command to recreate the project's database structure:
```
dotnet ef database update
```
4. Verify that the database structure is present by refreshing the MySQL workbench schemas. There should now be a directory for pupper_.
5. To run the database on your local host, run the following commands:
```
dotnet restore
dotnet build
dotnet run
```

#### To run the MVC program:
To install the necessary dependencies and start a localhost, after replicating the database and ensuring it is also running on a different session (Example: API on port 5000, MVC on port 5006), run the following commands:
```
dotnet restore
dotnet build
dotnet run
```

### Known Bugs

No bugs have been identified at the time of this update.


### Support and Contact Information

_Have a bug or an issue with this application? [Open a new issue](https://github.com/jhvozdovich/pupper-mvc/issues) here on GitHub._

### Technologies Used

* C#
* `ASP.NET` Core
* `ASP.NET` Core MVC
* Entity Framework Core
* `ASP.NET` Core Identity
* MySQL
* Git and GitHub

### Specs
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **User enters home page** | User Input:"URL: localhost:5000/" | Output: “Welcome!” |
| **User can view all dogs** | User Input:"Click: Dogs" | Output: “List of all dogs ” |
| **User can view details for each dog** | User Input:"Click: Bagera" | Output: "Name: Bagera, Breed: Dachshund, Age: 11, PicUrl: www.sample.com, Gender: Male"|
| **User can add a dog** | User Input:"Click: Add Dog" | Output: “Add dog form: Name: Matilda, Breed: Mutt, Age: 7, PicUrl: www.sample.com, Gender: Female, DoggoID: Auto Incremented” |
| **User can update a dog's details** | User Input:"Click: dog ID, Click: Update" | Output: Name: Matilda, Breed: Mutt, Age: 8, PicUrl: www.newphotosample.com, Gender: Female, DoggoID: Auto Incremented” |
| **User can delete dogs from list** | User Input:"Click Remove" | Output: “Dog Removed” |
| **User can search for a dog by name** | User Input:"Search by Name: Matilda" | Output: "Name: Matilda, Breed: Mutt, Age: 8, PicUrl: www.newphotosample.com, Gender: Female" |
| **User can search for a dog by breed** | User Input:"Search by Breed: Dachshund" | Output: "Bagera, Cody, Oscar” |
| **User can search for a dog by id** | User Input:"Search by id: 1" | Output: "Name: Bagera, Breed: Dachshund, Age: 11, PicUrl: www.sample.com, Gender: Male" |

#### License

This software is licensed under the MIT license.

Copyright © 2020 **_Jessica Hvozdovich and Christopher Huber_**