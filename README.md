To run the frontend:

```bash
cd frontend
npm install
npm run dev
```


To run the backend:

```bash
cd backend
dotnet restore
dotnet run
```

Estimations and actual development times:

| Task                                                               | Estimated Time | Actual Time |
|--------------------------------------------------------------------|----------------|-------------|
| **Project setup**                                                  | 30 mins        | 20 mins     |
| **Frontend**                                                       |                |             |
| Template of the Form component, CSS layout, color config           | 60 mins        | 56 mins     |
| Write and test validation functions                                | 30 mins        | 33 mins     |
| Add toasts for validation feedback                                 | 45 mins        | 21 mins     |
| Implementation of the query function and toast to give feedback    | 30 mins        | 31 mins     |
| **Total Frontend**                                                 | **165 mins**   | **141 mins**|
| **Backend**                                                        |                |             |
| GET contacts endpoint                                              | 30 mins        | 30 mins     |
| POST contacts endpoint, linking backend to the frontend            | 45 mins        | 49 mins     |
| **Total Backend**                                                  | **75 mins**    | **79 mins** |
| **Project Total**                                                  | **270 mins**   | **240 mins**|

