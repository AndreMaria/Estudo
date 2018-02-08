var gulp = require('gulp');
var protractor = require("gulp-protractor").protractor;
var reporter  = require("gulp-protractor-cucumber-html-report");

gulp.task("execute",function(){
  return gulp.src([]).pipe(protractor({
    configFile: "config.js"
  })).on('error',function(e){ throw e})
});

gulp.task("report",function(){
  return gulp.src("reports/results.js").pipe(reporter({
    dest: "reports"
  }))
});
