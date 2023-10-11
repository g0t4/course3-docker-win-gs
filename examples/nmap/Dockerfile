FROM debian:bookworm-slim

RUN <<SCRIPT

  apt-get update
  apt-get install -y nmap
  rm -rf /var/lib/apt/lists/*

SCRIPT

ENTRYPOINT ["nmap"]
