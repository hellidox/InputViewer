# PLEASE USE THE PROVIDED DNSPY.XML

If your pull request touches every file it won't be merged!

# Patch Notes

## V2.0.8.1
- You can now properly opt out of analytics. Only reason you couldn't before is because i forgo t
- Mod source code is now public at https://github.com/hellidox/InputViewer (you could already just use dnspy and i still recommend dnspy, however this does have a diff thing and commit messages built in so that's nice)
- Total points are tracked (but not displayed, they'll be there when i fix the display) (am i stupid?)
- You can now disable FPS counter (showFPS in config)
- Optimized Practice UI by a lot (original calls string.Format every frame, this calls ZString.AppendFormat 30 times per second
  ZString.AppendFormat doesn't generate garbage so less lag spikes
