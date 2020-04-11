# ROCKET ELEVATORS INFORMATION SYSTEM API'S

  Goal for the week : Implement REST API for the intervention table

## Endpoints
  - GET - https://rocketelevsmtl.azurewebsites.net/api/Interventions

  - GET - https://rocketelevsmtl.azurewebsites.net/api/Interventions/{id}
  
  - GET - https://rocketelevsmtl.azurewebsites.net/api/Interventions/Pending

  - PUT - https://rocketelevsmtl.azurewebsites.net/api/Interventions/{id}/ChangeStatus
  
  example of a JSON request body:  

{ "status" : "InProgress" (or "Completed") }
