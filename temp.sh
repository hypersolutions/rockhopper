#!/bin/bash
# ver="/refs/tags/v/v0.1.0"
# echo $ver
# replacement="/refs/tags/v/"
# replace_with=""
# x=${ver#replacement}
# echo $x
# echo "${ver/replacement/replace_with}"

string="/refs/tags/v/v0.1.0"
result="${string##*/v}"
echo "$result"

read -p "Press Enter to continue" </dev/tty