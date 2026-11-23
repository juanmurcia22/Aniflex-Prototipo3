package com.aniflex.rest.config;

import com.mongodb.ConnectionString;
import com.mongodb.MongoClientSettings;
import com.mongodb.client.MongoClient;
import com.mongodb.client.MongoClients;
import com.mongodb.client.MongoDatabase;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import java.util.concurrent.TimeUnit;

@Configuration
public class MongoConfig {
    @Bean(destroyMethod = "close")
    public MongoClient mongoClient(@Value("${aniflex.mongodb.uri}") String uri,
                                   @Value("${aniflex.mongodb.timeout-segundos}") int timeout) {
        var settings = MongoClientSettings.builder()
                .applyConnectionString(new ConnectionString(uri))
                .applyToClusterSettings(cluster -> cluster.serverSelectionTimeout(timeout, TimeUnit.SECONDS))
                .build();
        return MongoClients.create(settings);
    }

    @Bean
    public MongoDatabase mongoDatabase(MongoClient client,
                                       @Value("${aniflex.mongodb.database}") String database) {
        return client.getDatabase(database);
    }
}
