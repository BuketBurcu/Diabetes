dotnet publish DiabetesControl/DiabetesControl.csproj -c Debug -o publish

docker build --tag diabetescontrol:latest --no-cache -f DiabetesDockerfile .

docker tag diabetescontrol:latest buketbm/diabetes

docker push buketbm/diabetes