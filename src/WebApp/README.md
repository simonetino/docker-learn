# Web App

This is a ASP.NET Core sample application to demonstrate how to run a web app in Docker.

## Getting Started

First, run the `build.ps1` script which will publish the application in the `output` folder:

```bash
build.ps1
```

Use the `Dockerfile` to create an image with the deployed application in `output`:

```bash
docker build -t webapp .
```

A docker image with name `webapp` is available in the local repository.

To create and run a container:

```bash
docker run --name webapp-container -d -p 5000:80 webapp
```

The application will listen for requests at:
http://localhost:5000