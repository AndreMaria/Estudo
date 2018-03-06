exports.config = {

  directConnect: true,

  specs: [
    '../../assets/test/e2e/features/**/*.feature'
  ],

  capabilities: {
    browserName: 'chrome',
  },

  maxSessions: 1,

  onPrepare: function () {
    browser.manage().timeouts().pageLoadTimeout(400000);
    browser.manage().timeouts().implicitlyWait(250000);

    // for non-angular page
    browser.ignoreSynchronization = true;
  },

  framework: 'custom',
  frameworkPath: require.resolve('protractor-cucumber-framework'),

  cucumberOpts: {
    require: [
      '../../assets/test/e2e/features/step_definitions/**/*step_definition.js',
      '../../assets/test/e2e/features/support/*.js'
    ],
    tags: '@rodrigo',
    format: 'pretty'
  }
}
