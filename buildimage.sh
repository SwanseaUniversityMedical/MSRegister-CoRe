docker build -f ./MSRegister-CoRe/Dockerfile  .  --build-arg="HTTP_PROXY=http://192.168.10.15:8080" --build-arg="HTTPS_PROXY=http://192.168.10.15:8080" -t msregistercore:latest