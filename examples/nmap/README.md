## Commands

```bash

# build:
docker compose build --pull

# tests:
docker compose run --rm nmap -V
docker compose run --rm nmap -v -A scanme.nmap.org

# aio:
docker compose run --rm --build nmap -v -A scanme.nmap.org

# cleanup:
docker container prune # if not using `--rm` with `run`
docker compose down --rmi local

```


## Links

- https://docs.docker.com/reference/
  - Dockerfile: https://docs.docker.com/engine/reference/builder/
  - compose: https://docs.docker.com/compose/compose-file/
- https://docs.docker.com/develop/develop-images/instructions/