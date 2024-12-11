using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using YamlDotNet.RepresentationModel;

public class \u02B4\u02B4\u02B6\u02B9\u02B7\u02C1\u02B5\u02B9\u02BC\u02BD\u02BE : \u02BE\u02BF\u02B6\u02BC\u02BC\u02B9\u02B5\u02B3\u02B8\u02C0\u02B8
{
	private static void \u02BD\u02C0\u02B9\u02BC\u02BC\u02BA\u02C1\u02C0\u02BA\u02BE\u02B8(\u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA? \u02BF\u02B5\u02B6\u02BE\u02B3\u02BD\u02BE\u02BF\u02B6\u02B5\u02B6, KeyValuePair<YamlNode, YamlNode> \u02B7\u02B3\u02BF\u02BF\u02B4\u02B8\u02C0\u02BB\u02BB\u02BF\u02BE, \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC? \u02B8\u02BD\u02BD\u02BB\u02BF\u02BD\u02B2\u02B5\u02BA\u02B3\u02BF, YamlNode \u02B9\u02B5\u02BC\u02BD\u02B2\u02C0\u02C1\u02BC\u02BC\u02B9\u02B4)
	{
		if (\u02B9\u02B5\u02BC\u02BD\u02B2\u02C0\u02C1\u02BC\u02BC\u02B9\u02B4.NodeType == YamlNodeType.Scalar)
		{
			throw new FileLoadException(string.Format("Resulting node for isolation '{0}' in language file '{1}' is a scalar node which cannot provide further resources: On path '{2}'", \u02B8\u02BD\u02BD\u02BB\u02BF\u02BD\u02B2\u02B5\u02BA\u02B3\u02BF, \u02B7\u02B3\u02BF\u02BF\u02B4\u02B8\u02C0\u02BB\u02BB\u02BF\u02BE.Key, \u02BF\u02B5\u02B6\u02BE\u02B3\u02BD\u02BE\u02BF\u02B6\u02B5\u02B6.ToString()));
		}
	}

	protected void \u02B2\u02BB\u02B4\u02B8\u02BC\u02C1\u02B8\u02B5\u02B9\u02B9\u02B4(YamlNode \u02B4\u02BF\u02B2\u02BD\u02C1\u02BA\u02BA\u02BF\u02BD\u02BF\u02B4, ref TranslationNode \u02C0\u02BF\u02C1\u02BD\u02B8\u02BF\u02B6\u02B5\u02BB\u02B9\u02B3, bool \u02BE\u02BA\u02B4\u02B6\u02BD\u02B3\u02BD\u02B5\u02BD\u02C0\u02C0)
	{
		Dictionary<\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC, Dictionary<\u02BA\u02BE\u02B5\u02BF\u02BE\u02BE\u02B9\u02C1\u02B2\u02BB\u02C0, string>> dictionary = new Dictionary<\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC, Dictionary<\u02BA\u02BE\u02B5\u02BF\u02BE\u02BE\u02B9\u02C1\u02B2\u02BB\u02C0, string>>();
		YamlSequenceNode yamlSequenceNode = \u02B4\u02BF\u02B2\u02BD\u02C1\u02BA\u02BA\u02BF\u02BD\u02BF\u02B4 as YamlSequenceNode;
		if (yamlSequenceNode == null)
		{
			YamlMappingNode yamlMappingNode = \u02B4\u02BF\u02B2\u02BD\u02C1\u02BA\u02BA\u02BF\u02BD\u02BF\u02B4 as YamlMappingNode;
			if (yamlMappingNode != null)
			{
				foreach (KeyValuePair<YamlNode, YamlNode> keyValuePair in yamlMappingNode.Children)
				{
					\u02B4\u02B4\u02B6\u02B9\u02B7\u02C1\u02B5\u02B9\u02BC\u02BD\u02BE.\u02BF\u02B5\u02B3\u02BE\u02BA\u02B3\u02BA\u02C1\u02B8\u02BD\u02B6 u02BF_u02B5_u02B3_u02BE_u02BA_u02B3_u02BA_u02C1_u02B8_u02BD_u02B = new \u02B4\u02B4\u02B6\u02B9\u02B7\u02C1\u02B5\u02B9\u02BC\u02BD\u02BE.\u02BF\u02B5\u02B3\u02BE\u02BA\u02B3\u02BA\u02C1\u02B8\u02BD\u02B6();
					bool flag = true;
					u02BF_u02B5_u02B3_u02BE_u02BA_u02B3_u02BA_u02C1_u02B8_u02BD_u02B.pluralDictionary = new Dictionary<\u02BA\u02BE\u02B5\u02BF\u02BE\u02BE\u02B9\u02C1\u02B2\u02BB\u02C0, string>();
					YamlNode value = keyValuePair.Value;
					YamlMappingNode yamlMappingNode2 = value as YamlMappingNode;
					if (yamlMappingNode2 == null)
					{
						if (!(value is YamlScalarNode))
						{
							YamlSequenceNode yamlSequenceNode2 = value as YamlSequenceNode;
							if (yamlSequenceNode2 != null)
							{
								for (int i = 0; i < yamlSequenceNode2.Children.Count<YamlNode>(); i++)
								{
									TranslationNode translationNode = new TranslationNode();
									this.\u02B2\u02BB\u02B4\u02B8\u02BC\u02C1\u02B8\u02B5\u02B9\u02B9\u02B4(yamlSequenceNode2.Children[i], ref translationNode, \u02BE\u02BA\u02B4\u02B6\u02BD\u02B3\u02BD\u02B5\u02BD\u02C0\u02C0);
									\u02C0\u02BF\u02C1\u02BD\u02B8\u02BF\u02B6\u02B5\u02BB\u02B9\u02B3.\u02B4\u02B4\u02B9\u02BC\u02BE\u02BB\u02BB\u02B9\u02B9\u02B9\u02BE.Add(\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC.\u02B4\u02C1\u02BA\u02B8\u02B2\u02B6\u02B8\u02B5\u02B9\u02B9\u02BF(i), translationNode);
								}
								flag = false;
							}
						}
						else
						{
							u02BF_u02B5_u02B3_u02BE_u02BA_u02B3_u02BA_u02C1_u02B8_u02BD_u02B.pluralDictionary.Add(\u02BA\u02BE\u02B5\u02BF\u02BE\u02BE\u02B9\u02C1\u02B2\u02BB\u02C0.Other, ((YamlScalarNode)keyValuePair.Value).Value);
						}
					}
					else
					{
						List<ValueTuple<\u02BA\u02BE\u02B5\u02BF\u02BE\u02BE\u02B9\u02C1\u02B2\u02BB\u02C0, string>> list = new List<ValueTuple<\u02BA\u02BE\u02B5\u02BF\u02BE\u02BE\u02B9\u02C1\u02B2\u02BB\u02C0, string>>();
						foreach (KeyValuePair<YamlNode, YamlNode> keyValuePair2 in yamlMappingNode2.Children)
						{
							\u02BA\u02BE\u02B5\u02BF\u02BE\u02BE\u02B9\u02C1\u02B2\u02BB\u02C0 u02BA_u02BE_u02B5_u02BF_u02BE_u02BE_u02B9_u02C1_u02B2_u02BB_u02C;
							if (!Enum.TryParse<\u02BA\u02BE\u02B5\u02BF\u02BE\u02BE\u02B9\u02C1\u02B2\u02BB\u02C0>(((YamlScalarNode)keyValuePair2.Key).Value, true, out u02BA_u02BE_u02B5_u02BF_u02BE_u02BE_u02B9_u02C1_u02B2_u02BB_u02C))
							{
								flag = false;
								break;
							}
							list.Add(new ValueTuple<\u02BA\u02BE\u02B5\u02BF\u02BE\u02BE\u02B9\u02C1\u02B2\u02BB\u02C0, string>(u02BA_u02BE_u02B5_u02BF_u02BE_u02BE_u02B9_u02C1_u02B2_u02BB_u02C, ((YamlScalarNode)keyValuePair2.Value).Value));
						}
						if (list.Count == yamlMappingNode2.Children.Count)
						{
							list.ForEach(new Action<ValueTuple<\u02BA\u02BE\u02B5\u02BF\u02BE\u02BE\u02B9\u02C1\u02B2\u02BB\u02C0, string>>(u02BF_u02B5_u02B3_u02BE_u02BA_u02B3_u02BA_u02C1_u02B8_u02BD_u02B.\u02BC\u02BE\u02BB\u02BF\u02BC\u02BC\u02B3\u02B4\u02B4\u02B7\u02BC));
						}
						else if (\u02BE\u02BA\u02B4\u02B6\u02BD\u02B3\u02BD\u02B5\u02BD\u02C0\u02C0)
						{
							TranslationNode translationNode2 = new TranslationNode();
							string value2 = ((YamlScalarNode)keyValuePair.Key).Value;
							this.\u02B2\u02BB\u02B4\u02B8\u02BC\u02C1\u02B8\u02B5\u02B9\u02B9\u02B4(yamlMappingNode2, ref translationNode2, \u02BE\u02BA\u02B4\u02B6\u02BD\u02B3\u02BD\u02B5\u02BD\u02C0\u02C0);
							\u02C0\u02BF\u02C1\u02BD\u02B8\u02BF\u02B6\u02B5\u02BB\u02B9\u02B3.\u02B4\u02B4\u02B9\u02BC\u02BE\u02BB\u02BB\u02B9\u02B9\u02B9\u02BE.Add(\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC.\u02B4\u02C1\u02BA\u02B8\u02B2\u02B6\u02B8\u02B5\u02B9\u02B9\u02BF(value2), translationNode2);
						}
					}
					if (flag)
					{
						dictionary.Add(\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC.\u02B4\u02C1\u02BA\u02B8\u02B2\u02B6\u02B8\u02B5\u02B9\u02B9\u02BF(((YamlScalarNode)keyValuePair.Key).Value), u02BF_u02B5_u02B3_u02BE_u02BA_u02B3_u02BA_u02C1_u02B8_u02BD_u02B.pluralDictionary);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < yamlSequenceNode.Children.Count<YamlNode>(); j++)
			{
				YamlScalarNode yamlScalarNode = yamlSequenceNode.Children[j] as YamlScalarNode;
				if (yamlScalarNode != null)
				{
					Dictionary<\u02BA\u02BE\u02B5\u02BF\u02BE\u02BE\u02B9\u02C1\u02B2\u02BB\u02C0, string> dictionary2 = new Dictionary<\u02BA\u02BE\u02B5\u02BF\u02BE\u02BE\u02B9\u02C1\u02B2\u02BB\u02C0, string> { 
					{
						\u02BA\u02BE\u02B5\u02BF\u02BE\u02BE\u02B9\u02C1\u02B2\u02BB\u02C0.Other,
						yamlScalarNode.Value
					} };
					dictionary.Add(\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC.\u02B4\u02C1\u02BA\u02B8\u02B2\u02B6\u02B8\u02B5\u02B9\u02B9\u02BF(\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC.\u02BE\u02B7\u02BB\u02B6\u02BF\u02B6\u02B9\u02B2\u02B3\u02C0\u02B3(j)), dictionary2);
				}
				else
				{
					TranslationNode translationNode3 = new TranslationNode();
					this.\u02B2\u02BB\u02B4\u02B8\u02BC\u02C1\u02B8\u02B5\u02B9\u02B9\u02B4(yamlSequenceNode.Children[j], ref translationNode3, \u02BE\u02BA\u02B4\u02B6\u02BD\u02B3\u02BD\u02B5\u02BD\u02C0\u02C0);
					\u02C0\u02BF\u02C1\u02BD\u02B8\u02BF\u02B6\u02B5\u02BB\u02B9\u02B3.\u02B4\u02B4\u02B9\u02BC\u02BE\u02BB\u02BB\u02B9\u02B9\u02B9\u02BE.Add(\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC.\u02B4\u02C1\u02BA\u02B8\u02B2\u02B6\u02B8\u02B5\u02B9\u02B9\u02BF(j), translationNode3);
				}
			}
		}
		\u02C0\u02BF\u02C1\u02BD\u02B8\u02BF\u02B6\u02B5\u02BB\u02B9\u02B3.Resources = dictionary;
	}

	public void \u02B2\u02BB\u02B4\u02B8\u02BC\u02C1\u02B8\u02B5\u02B9\u02B9\u02B4(string \u02C0\u02BB\u02BE\u02BE\u02C0\u02B4\u02B3\u02BB\u02B6\u02BA\u02BF, \u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA? \u02B2\u02B2\u02B9\u02C1\u02B4\u02BC\u02B9\u02B9\u02B8\u02BE\u02B2, out TranslationNode \u02BA\u02BA\u02B9\u02B6\u02BB\u02BF\u02B9\u02B9\u02B4\u02B5\u02B7, bool \u02BE\u02BA\u02B4\u02B6\u02BD\u02B3\u02BD\u02B5\u02BD\u02C0\u02C0 = false)
	{
		TranslationNode translationNode = new TranslationNode();
		if (\u02C0\u02BB\u02BE\u02BE\u02C0\u02B4\u02B3\u02BB\u02B6\u02BA\u02BF != null)
		{
			YamlStream yamlStream = new YamlStream();
			yamlStream.Load(new StringReader(\u02C0\u02BB\u02BE\u02BE\u02C0\u02B4\u02B3\u02BB\u02B6\u02BA\u02BF));
			foreach (KeyValuePair<YamlNode, YamlNode> keyValuePair in ((YamlMappingNode)yamlStream.Documents[0].RootNode).Children)
			{
				YamlNode yamlNode = keyValuePair.Value;
				if (\u02B2\u02B2\u02B9\u02C1\u02B4\u02BC\u02B9\u02B9\u02B8\u02BE\u02B2 != null && !\u02B2\u02B2\u02B9\u02C1\u02B4\u02BC\u02B9\u02B9\u02B8\u02BE\u02B2.Value.Equals(\u02B5\u02B4\u02C1\u02BA\u02C1\u02BF\u02B9\u02C0\u02C1\u02B6\u02BA.\u02BB\u02C1\u02B5\u02BA\u02B7\u02BC\u02B3\u02B6\u02B2\u02C1\u02BE))
				{
					for (int i = 0; i < ((\u02B2\u02B2\u02B9\u02C1\u02B4\u02BC\u02B9\u02B9\u02B8\u02BE\u02B2 != null) ? \u02B2\u02B2\u02B9\u02C1\u02B4\u02BC\u02B9\u02B9\u02B8\u02BE\u02B2.GetValueOrDefault().\u02C1\u02B4\u02B4\u02B9\u02C0\u02B4\u02B2\u02BE\u02BC\u02B8\u02BD.Length : 0); i++)
					{
						\u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC? u02B7_u02B6_u02BE_u02B4_u02B4_u02C0_u02B2_u02C0_u02B7_u02BE_u02BC = ((\u02B2\u02B2\u02B9\u02C1\u02B4\u02BC\u02B9\u02B9\u02B8\u02BE\u02B2 != null) ? new \u02B7\u02B6\u02BE\u02B4\u02B4\u02C0\u02B2\u02C0\u02B7\u02BE\u02BC?(\u02B2\u02B2\u02B9\u02C1\u02B4\u02BC\u02B9\u02B9\u02B8\u02BE\u02B2.GetValueOrDefault().\u02C1\u02B4\u02B4\u02B9\u02C0\u02B4\u02B2\u02BE\u02BC\u02B8\u02BD[i]) : null);
						if (u02B7_u02B6_u02BE_u02B4_u02B4_u02C0_u02B2_u02C0_u02B7_u02BE_u02BC != null && u02B7_u02B6_u02BE_u02B4_u02B4_u02C0_u02B2_u02C0_u02B7_u02BE_u02BC.GetValueOrDefault().\u02B3\u02B6\u02BF\u02B3\u02BA\u02B4\u02B5\u02B2\u02BD\u02BF\u02C0 == \u02BB\u02B6\u02BC\u02B3\u02B4\u02B3\u02C1\u02C1\u02B7\u02C0\u02B4.MAPPING_KEY && yamlNode.NodeType == YamlNodeType.Mapping)
						{
							YamlNode yamlNode2;
							if (!((YamlMappingNode)yamlNode).Children.TryGetValue(u02B7_u02B6_u02BE_u02B4_u02B4_u02C0_u02B2_u02C0_u02B7_u02BE_u02BC.Value.\u02BA\u02BD\u02B2\u02B5\u02BF\u02BD\u02B2\u02B5\u02BC\u02BC\u02B8, out yamlNode2))
							{
								throw new FileLoadException(string.Format("Text resource in language file '{0}' cannot isolate to mapping node level '{1}' for key mapping path '{2}'. Please check file to see if path exists.", keyValuePair.Key, u02B7_u02B6_u02BE_u02B4_u02B4_u02C0_u02B2_u02C0_u02B7_u02BE_u02BC, \u02B2\u02B2\u02B9\u02C1\u02B4\u02BC\u02B9\u02B9\u02B8\u02BE\u02B2.ToString()));
							}
							\u02B4\u02B4\u02B6\u02B9\u02B7\u02C1\u02B5\u02B9\u02BC\u02BD\u02BE.\u02BD\u02C0\u02B9\u02BC\u02BC\u02BA\u02C1\u02C0\u02BA\u02BE\u02B8(\u02B2\u02B2\u02B9\u02C1\u02B4\u02BC\u02B9\u02B9\u02B8\u02BE\u02B2, keyValuePair, u02B7_u02B6_u02BE_u02B4_u02B4_u02C0_u02B2_u02C0_u02B7_u02BE_u02BC, yamlNode2);
							yamlNode = yamlNode2;
						}
						else
						{
							if (u02B7_u02B6_u02BE_u02B4_u02B4_u02C0_u02B2_u02C0_u02B7_u02BE_u02BC == null || u02B7_u02B6_u02BE_u02B4_u02B4_u02C0_u02B2_u02C0_u02B7_u02BE_u02BC.GetValueOrDefault().\u02B3\u02B6\u02BF\u02B3\u02BA\u02B4\u02B5\u02B2\u02BD\u02BF\u02C0 != \u02BB\u02B6\u02BC\u02B3\u02B4\u02B3\u02C1\u02C1\u02B7\u02C0\u02B4.SEQUENCE_INDEX || yamlNode.NodeType != YamlNodeType.Sequence)
							{
								throw new FileLoadException("Path " + \u02B2\u02B2\u02B9\u02C1\u02B4\u02BC\u02B9\u02B9\u02B8\u02BE\u02B2.ToString() + " cannot find next node called " + u02B7_u02B6_u02BE_u02B4_u02B4_u02C0_u02B2_u02C0_u02B7_u02BE_u02BC.ToString());
							}
							YamlSequenceNode yamlSequenceNode = (YamlSequenceNode)yamlNode;
							if (yamlSequenceNode.Children.Count >= u02B7_u02B6_u02BE_u02B4_u02B4_u02C0_u02B2_u02C0_u02B7_u02BE_u02BC.Value.\u02BE\u02B2\u02BE\u02B6\u02C0\u02C1\u02BB\u02B7\u02C0\u02B3\u02BD)
							{
								throw new FileLoadException(string.Format("Text resource in language file '{0}' c", keyValuePair.Key));
							}
							YamlNode yamlNode3 = yamlSequenceNode.Children[u02B7_u02B6_u02BE_u02B4_u02B4_u02C0_u02B2_u02C0_u02B7_u02BE_u02BC.Value.\u02BE\u02B2\u02BE\u02B6\u02C0\u02C1\u02BB\u02B7\u02C0\u02B3\u02BD];
							\u02B4\u02B4\u02B6\u02B9\u02B7\u02C1\u02B5\u02B9\u02BC\u02BD\u02BE.\u02BD\u02C0\u02B9\u02BC\u02BC\u02BA\u02C1\u02C0\u02BA\u02BE\u02B8(\u02B2\u02B2\u02B9\u02C1\u02B4\u02BC\u02B9\u02B9\u02B8\u02BE\u02B2, keyValuePair, u02B7_u02B6_u02BE_u02B4_u02B4_u02C0_u02B2_u02C0_u02B7_u02BE_u02BC, yamlNode3);
							yamlNode = yamlNode3;
						}
					}
				}
				this.\u02B2\u02BB\u02B4\u02B8\u02BC\u02C1\u02B8\u02B5\u02B9\u02B9\u02B4(yamlNode, ref translationNode, \u02BE\u02BA\u02B4\u02B6\u02BD\u02B3\u02BD\u02B5\u02BD\u02C0\u02C0);
			}
		}
		\u02BA\u02BA\u02B9\u02B6\u02BB\u02BF\u02B9\u02B9\u02B4\u02B5\u02B7 = translationNode;
	}

	[CompilerGenerated]
	private sealed class \u02BF\u02B5\u02B3\u02BE\u02BA\u02B3\u02BA\u02C1\u02B8\u02BD\u02B6
	{
		internal void \u02BC\u02BE\u02BB\u02BF\u02BC\u02BC\u02B3\u02B4\u02B4\u02B7\u02BC(ValueTuple<\u02BA\u02BE\u02B5\u02BF\u02BE\u02BE\u02B9\u02C1\u02B2\u02BB\u02C0, string> kvp)
		{
			this.pluralDictionary.Add(kvp.Item1, kvp.Item2);
		}

		public Dictionary<\u02BA\u02BE\u02B5\u02BF\u02BE\u02BE\u02B9\u02C1\u02B2\u02BB\u02C0, string> pluralDictionary;
	}
}
