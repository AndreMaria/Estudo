const { SpecReporter } = require('jasmine-spec-reporter');

exports.config = {
  defaultTimeoutInterval: 25000,
  allScriptsTimeout: 310000,
  getPageTimeout: 300000,
  specs: [
    './features/*.feature'
  ],
  capabilities: {
    'browserName': 'chrome'
  },
  directConnect: true,
  baseUrl: 'http://localhost:49158/',
  framework: 'custom',
  frameworkPath : require.resolve('protractor-cucumber-framework'),
  cucumberOpts: {
    require: [
      './features/step_definitions/*steps.js'
    ]
  }
};
