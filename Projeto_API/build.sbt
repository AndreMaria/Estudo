name := "Projeto_API"

version := "0.1"

scalaVersion := "2.11.8"

libraryDependencies ++= Seq(
  //"com.typesafe.akka" % "akka-actor_2.12" % "2.4.14"
  // For Akka 2.4.x or 2.5.x
  "com.typesafe.akka" %% "akka-http" % "10.0.10",
  // Only when running against Akka 2.5 explicitly depend on akka-streams in same version as akka-actor
  "com.typesafe.akka" %% "akka-stream" % "2.5.4", // or whatever the latest version is
  "com.typesafe.akka" %% "akka-actor"  % "2.5.4", // or whatever the latest version is
  "com.typesafe.akka" %% "akka-http-spray-json-experimental" % "2.4.6"
)

libraryDependencies += "org.json4s" %% "json4s-native" % "3.6.0-M2"
libraryDependencies += "mysql" % "mysql-connector-java" % "5.1.9"
libraryDependencies += "javax.transaction" % "jta" % "1.1"
libraryDependencies += "org.hibernate" % "hibernate-entitymanager" % "3.3.2.GA" pomOnly()
//libraryDependencies += "org.hibernate" % "hibernate-entitymanager" % "3.3.2.GA"