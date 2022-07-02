FROM ghcr.io/mazharenko/dotnet-interactive-docker:main

COPY --chown=1000 ./notebooks ${HOME}/Notebooks/

WORKDIR ${HOME}/Notebooks/