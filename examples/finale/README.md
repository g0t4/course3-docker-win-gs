## Notes

- https://hub.docker.com/_/microsoft-mssql-server
- https://hub.docker.com/_/mysql
- https://hub.docker.com/_/adminer
- https://hub.docker.com/_/postgres
- https://hub.docker.com/_/mongo

```bash

# mysql
docker compose exec mysql bash
  mysql -u root -p
    show databases;
    exit

# mongo's shell:
docker compose exec mongo bash
  mongosh
```
