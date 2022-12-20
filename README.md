# openIMIS Web Application

The openIMIS Web Application is the main component of the openIMIS infrastructure.
It is used to manage all openIMIS entities from any browser.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

In order to use and develop the openIMIS Web Application on your local machine, you first need to install:

* SQL Server instance (follow [database installation](https://github.com/openimis/database_ms_sqlserver))


### Installing

To make a copy of this project on your local machine, please clone the repository.

```
git clone https://github.com/openimis/web_app_vb
```

Restore the NuGet packages needed by the application using VS or [nuget CLI](https://www.nuget.org/downloads).

```
nuget restore
```

From the [IMIS](./IMIS/) folder, remove the .dist extension from web.debug.config.dist, or web.release.config.dist
(depending on which configuration you need). In the chosen file, change the connection string to connect to the database.

```
<add name="IMISConnectionString" connectionString="Data Source=[DatabaseIPAdress];Initial Catalog=IMIS;User ID=[ImisUserId];Password=[ImisUserPassword]" providerName="System.Data.SqlClient"/>
```

Then, build the application via Visual Studio; this action will also generate the web.config file. The latter is not
included in the sources for privacy purpose.

<!--## Running the tests

Explain how to run the automated tests for this system

### Break down into end to end tests

Explain what these tests test and why

```
Give an example
```

### And coding style tests

Explain what these tests test and why

```
Give an example
```-->

## Deployment

For deployment please read the [installation manual](https://openimis.atlassian.net/wiki/spaces/OP/pages/906952742/WA2.2+Web+Application+installation).

<!--## Built With

* [Visual Studio](https://visualstudio.microsoft.com/) - The web framework used
* [Dropwizard](http://www.dropwizard.io/1.0.2/docs/) - The web framework used
* [Maven](https://maven.apache.org/) - Dependency Management
* [ROME](https://rometools.github.io/rome/) - Used to generate RSS Feeds
-->

<!--## Contributing

Please read [CONTRIBUTING.md](https://gist.github.com/PurpleBooth/b24679402957c63ec426) for details on our code of conduct, and the process for submitting pull requests to us.
-->

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/openimis/web_app_vb/tags). 


## Updates

* [Random Sampling] features added for Claims for easy reimbursement of the claimed amount by HSP
<!--## Authors

* **Billie Thompson** - *Initial work* - [PurpleBooth](https://github.com/PurpleBooth)

See also the list of [contributors](https://github.com/your/project/contributors) who participated in this project.
-->

## User Manual 

The user manual can be read on [openimis.readthedocs.io](http://openimis.readthedocs.io/en/latest/user_manual.html).

## Issues

To report a bug, request a new features or asking questions about openIMIS, please use the [openIMIS Service Desk](https://openimis.atlassian.net/servicedesk/customer/portal/1). 

## License

Copyright (c) Swiss Agency for Development and Cooperation (SDC)

This project is licensed under the GNU AGPL v3 License - see the [LICENSE.md](LICENSE.md) file for details.

<!--## Acknowledgments

* Hat tip to anyone whose code was used
* Inspiration
* etc
-->
