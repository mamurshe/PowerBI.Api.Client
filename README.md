PowerBI.Api.Client
=======

C# Client library to deal with PowerBI Rest Api.



## Installation

```
PM> Install-Package PowerBI.Api.Client
```

## Features

  * Automatic OAuth2 authenticate.
  * Dataset list
  * Dataset & tables creation
  * Insert datas in tables
  * Delete all datas in tables



## Getting start

To configure the Client Api you must use Configuration section

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
	<configSections>
		<section name="PowerBIConfiguration" type="PowerBI.Api.Client.Configuration.PowerBIConfiguration, PowerBI.Api.Client, Version=1.0.0.0"/>
	</configSections>
	<PowerBIConfiguration>
	    <OAuth
	      Authority="https://login.windows.net/common/oauth2/authorize" 
	      Resource="https://analysis.windows.net/powerbi/api"
	      Client="MyClientId" 
      	  User="MyUserName" 
      	  Password="MyPassword"/>
	    <Api 
	      Url="https://api.powerbi.com/beta/myorg/datasets" />
	  </PowerBIConfiguration>
</configuration>
```

Client is now ready. It's simple to use, call the Do method of PowerBIClient class to define an Action which use a connected instance.

```csharp
PowerBIClient.Do(api => {

});
```



## Licence

The MIT License (MIT)

Copyright (c) 2015 Sylvain PONTOREAU (pontoreau.sylvain@gmail.com)

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
the Software, and to permit persons to whom the Software is furnished to do so,
subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.



