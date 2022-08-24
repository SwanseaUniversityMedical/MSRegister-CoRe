docker tag msregistercore:dev harbor.ukserp.ac.uk:443/ms-register/msregistercore:latest
docker login harbor.ukserp.ac.uk:443/ms-register
docker push harbor.ukserp.ac.uk:443/ms-register/msregistercore:latest