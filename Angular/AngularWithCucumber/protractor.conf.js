// Protractor configuration file, see link for more information
// https://github.com/angular/protractor/blob/master/lib/config.ts

const { SpecReporter } = require('jasmine-spec-reporter');

exports.config = {
  defaultTimeoutInterval: 25000,
  allScriptsTimeout: 310000,
  getPageTimeout: 300000,
  specs: [
    './teste/e2e/features/*/*.feature'
  ],
  capabilities: {
    'browserName': 'chrome',
  },
  directConnect: true,
  baseURL: 'http://localhost:49162/',
  framework: 'custom',
  frameworkPath: require.resolve('protractor-cucumber-framework'),
  cucumberOpts: {
      require: [
        './teste/e2e/features/stepdefinition/*.steps.js'
      ]
  }
}
