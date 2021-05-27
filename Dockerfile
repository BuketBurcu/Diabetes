FROM mcr.microsoft.com/dotnet/core/aspnet:3.1  AS runtime
COPY publish/ diabetes
WORKDIR /diabetes
EXPOSE 80
EXPOSE 443

ENTRYPOINT ["dotnet", "DiabetesControl.dll"]