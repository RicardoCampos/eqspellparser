""" shift spell field indexes after a file update """

import sys, re

def fix(match):
  index = int(match.group(1))
  # 2018-5-9 removed 110 GLOBAL_GROUP
  # 2019-1-8 removed 77 AI_PT_BONUS
  if index > 76:
    return str(index - 1)
  return str(index)

text = open(sys.argv[1], 'r').read()

text = re.sub(r'(\d{2,3})', fix, text)

print(text)
