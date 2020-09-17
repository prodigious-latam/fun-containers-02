FROM postgres:12.3

COPY pagila-insert-data.sql /docker-entrypoint-initdb.d/pagila-insert-data.sql

ENV PGDATA=/data