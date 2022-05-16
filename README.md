## CQRS with debezium and elasticsearch
This is a example project for cqrs with CDC.This project is not a best practice or boilerplate. It is just an example for change data capture. Recommended that separate write and read APIs. If you do have significantly more reads that writes, there is a case for separating the API's so that you can scale your read API horizontally.

![image](https://user-images.githubusercontent.com/9461099/168598440-583097fb-2b90-4c53-ac83-79c1a8daba66.png)

From project root directory, start up your application by running  `docker-compose up`

After that login to mssql and run script file (enable cdc and create database)

Upload configurations to the connector
<pre><code>curl -i -X POST -H "Accept:application/json" -H "Content-Type:application/json" localhost:8083/connectors/ --data "@configName"
</code></pre>


<p>Check the connectors status, is it working</p>

<pre><code>curl localhost:8083/connectors/connectorName/status</code></pre>

Edit Mssql and Elasticsearch connection settings in appsettings.json and run the api
