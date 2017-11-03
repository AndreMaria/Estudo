FROM 137112412989.dkr.ecr.us-west-2.amazonaws.com/amazonlinux
RUN yum install -y java-1.8.0 tomcat8 initscripts
EXPOSE 8080
CMD /etc/init.d/tomcat8 start && wait && tail -f /var/log/tomcat8/catalina.out
