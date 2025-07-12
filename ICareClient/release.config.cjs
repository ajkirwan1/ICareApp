module.exports = {
  branches: [
    'master',
    { name: 'staging', prerelease: true },
    { name: 'develop', prerelease: 'dev' },
  ],
  plugins: [
    [
      '@semantic-release/commit-analyzer',
      {
        releaseRules: [
          { type: 'chore', release: 'patch' }, // your custom rule
        ],
      },
    ],
    [
      '@semantic-release/release-notes-generator',
      {
        preset: 'conventionalcommits',
        presetConfig: {
          types: [
            { type: 'feat', section: 'Features' },
            { type: 'fix', section: 'Bug Fixes' },
            { type: 'chore', section: 'Chores' },
            { type: null, section: 'Other Changes' }, // fallback catch-all to avoid invalid date error
          ],
        },
      },
    ],
    '@semantic-release/changelog',
    [
      '@semantic-release/git',
      {
        assets: ['CHANGELOG.md', 'package.json'],
        message: 'chore(release): ${nextRelease.version} [skip ci]',
      },
    ],
    '@semantic-release/npm',
    '@semantic-release/github',
  ],
}
