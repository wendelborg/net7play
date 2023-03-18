## Links
https://learn.microsoft.com/en-us/dotnet/core/docker/build-container?tabs=windows
https://joehonour.medium.com/a-guide-to-setting-up-a-net-core-project-using-docker-with-integrated-unit-and-component-tests-a326ca5a0284

docker build -t net7container -f Dockerfile .
docker scan net7container
docker run -it -p 5202:80 --rm net7container





https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-environment-variables


