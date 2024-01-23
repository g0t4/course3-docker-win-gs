# official examples:
#   https://github.com/JetBrains/teamcity-docker-samples
#   can also rely on expertise to specify instances (containers/services) in docker compose's compose.yaml files, i.e.:
#       https://github.com/JetBrains/teamcity-docker-samples/blob/master/compose-ubuntu/docker-compose.yml
#         DOCKER_IN_DOCKER env var for agent images
#         privileged: true for agents
#       similar idea to Dockerfile describing an environment, often by the people that make the software!
#         same with compose.yaml files!

# ! docker volume ls => shows ci_datdir, ci_logs
  # SHOW VOLUMES in Dashboard => look at some files
  # named volumes => meaningfully managed by docker (and docker volume ls) but can be same as anonymous volumes too
  #   dco down -v # to remove volumes too
  #     FYI `dco down -v` won't work after `dco down`, must include `-v` when destroying the containers that anonymous volumes belong to, 
  #       once you `down` a container w/ anonymous volumes they become dangling volumes
  #         they are not reused on next `dco up` => you will get new anon volumes on `up` after `down`
# share docs: https://docs.docker.com/compose/compose-file/03-compose-file/