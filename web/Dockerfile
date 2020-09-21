# Stage 0, "build-stage", based on Node.js, to build and compile the frontend
FROM node:14.8.0-alpine3.10 as build-stage

WORKDIR /app
COPY package*.json /app/

RUN npm install

COPY ./ /app/

ARG REACT_APP_API_URL

ENV REACT_APP_API_URL $REACT_APP_API_URL

RUN npm run build

# Stage 1, based on Nginx, to have only the compiled app, ready for production with Nginx
FROM nginx:1.19
COPY --from=build-stage /app/build/ /usr/share/nginx/html
