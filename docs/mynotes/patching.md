# Patching in `git`

```
git diff main HEAD -- ./path/to/file.txt ./another.txt > ./NoTrack/patch.diff
```

```
git apply --check ./NoTrack/patch.diff
```
