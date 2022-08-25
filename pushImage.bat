docker build -f MSRegister-CoRe\Dockerfile -t msregistercore:latest .
docker tag msregistercore:latest harbor.ukserp.ac.uk:443/ms-register/msregistercore:latest
docker login harbor.ukserp.ac.uk:443/ms-register
docker push harbor.ukserp.ac.uk:443/ms-register/msregistercore:latest