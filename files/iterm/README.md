# iTerm2 setup

Exported from iTerm2 3.7.3. Machine-specific state (window positions, `NoSync*` keys, updater bookkeeping) is stripped.

- `com.googlecode.iterm2.plist`: full preferences (general settings, key mappings, profiles)
- `profiles.json`: just the profiles (Default, Dropdown), importable on their own

## Restore

Full settings (quit iTerm2 first):

```sh
curl -fsSL https://grrom.github.io/files/iterm/com.googlecode.iterm2.plist -o /tmp/iterm2.plist
defaults import com.googlecode.iterm2 /tmp/iterm2.plist
```

Profiles only: iTerm2 → Settings → Profiles → Other Actions… → Import JSON Profiles → `profiles.json`.

The AI API key is stored in the Keychain and isn't included; re-enter it under Settings → General → AI.
