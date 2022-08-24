MSRegister-CoRe

Simple application to receive JSON from MS Register mobile app, deserialise it to C# classes and save to a database using Entity Framework

Very simple error checking
1. Is Study Id filled in
2. Is there a list of tests


The System will retuurn
"Saved" when its saved to teh database
"Error" when there is an error

The app will be responsible for checkign data is saved and doing any retry


C# app - build to run in Kestral or as a Docker Container.
Longer term plan is to create a HELM script and run on kuberneties with a load balancer with 2 or more instance runnign at any given moment.
