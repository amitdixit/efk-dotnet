# fluentd/Dockerfile

FROM fluent/fluentd:latest
USER root
RUN ["gem", "install", "fluent-plugin-elasticsearch", "--no-document", "--version", "5.2.3"]
USER fluent