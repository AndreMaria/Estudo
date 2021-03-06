name := "ApiScala"

version := "1.0"

scalaVersion := "2.12.4"

libraryDependencies ++= Seq(
  //"com.typesafe.akka" % "akka-actor_2.12" % "2.4.14"
  // For Akka 2.4.x or 2.5.x
  "com.typesafe.akka" %% "akka-http" % "10.0.10",
  // Only when running against Akka 2.5 explicitly depend on akka-streams in same version as akka-actor
  "com.typesafe.akka" %% "akka-stream" % "2.5.4", // or whatever the latest version is
  "com.typesafe.akka" %% "akka-actor"  % "2.5.4" // or whatever the latest version is
)

libraryDependencies += "com.typesafe.akka" %% "akka-http-spray-json" % "10.1.0-RC1"

// https://mvnrepository.com/artifact/mysql/mysql-connector-java
libraryDependencies += "mysql" % "mysql-connector-java" % "5.1.24"
    