FROM ruby:2.6.1

ENV RAILS_ENV production

RUN apt-get update && apt-get install -y nodejs --no-install-recommends && rm -rf /var/lib/apt/lists/*

RUN mkdir -p /app
WORKDIR /app
COPY . /app

RUN gem update --system
RUN gem install bundler
RUN bundle install

EXPOSE 3000

CMD ["rails", "server", "-b", "0.0.0.0"]

