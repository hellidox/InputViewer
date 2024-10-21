# PLEASE USE THE PROVIDED DNSPY.XML

If your pull request touches every file it won't be merged!

# Patch Notes

## V2.0.8.1

- Added proper analytics toggle
- Added total score stat
- Optimized Practice UI by a lot (original calls string.Format every frame, this calls ZString.AppendFormat 30 times per second
  ZString.AppendFormat doesn't generate garbage so less lag spikes
