SBT=./sbt
DOCKER=$(shell which docker)
docker_tag_name=scalatra_getting_started

server/local:
	$(SBT) ~jetty:start

server: package
	cd docker && $(MAKE) server

package: clean
	$(SBT) package
	cp -f target/scala-2.11/scalatra_getting_started_2.11-0.1.0-SNAPSHOT.war ./builds/ROOT.war

clean:
	rm -rf builds/*
