# we use the official Microsoft ASP.NET Core 3.1
# as this is the only dependency of our application
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

# copy the application deployment
COPY output/ /usr/local/webapp/

# set the image working directory
WORKDIR /usr/local/webapp

# define the entrypoinyt
ENTRYPOINT ["dotnet", "WebApp.dll"]