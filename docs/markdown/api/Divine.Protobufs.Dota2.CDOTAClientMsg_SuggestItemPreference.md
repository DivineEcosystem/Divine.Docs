# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference"></a> Class CDOTAClientMsg\_SuggestItemPreference

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_SuggestItemPreference : IMessage<CDOTAClientMsg_SuggestItemPreference>, IEquatable<CDOTAClientMsg_SuggestItemPreference>, IDeepCloneable<CDOTAClientMsg_SuggestItemPreference>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_SuggestItemPreference](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemPreference.md)

#### Implements

IMessage<CDOTAClientMsg\_SuggestItemPreference\>, 
[IEquatable<CDOTAClientMsg\_SuggestItemPreference\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_SuggestItemPreference\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CDOTAClientMsg\_SuggestItemPreference\>\(CDOTAClientMsg\_SuggestItemPreference, params CDOTAClientMsg\_SuggestItemPreference\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference__ctor"></a> CDOTAClientMsg\_SuggestItemPreference\(\)

```csharp
public CDOTAClientMsg_SuggestItemPreference()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_"></a> CDOTAClientMsg\_SuggestItemPreference\(CDOTAClientMsg\_SuggestItemPreference\)

```csharp
public CDOTAClientMsg_SuggestItemPreference(CDOTAClientMsg_SuggestItemPreference other)
```

#### Parameters

`other` [CDOTAClientMsg\_SuggestItemPreference](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemPreference.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_ItemPreferencesFieldNumber"></a> ItemPreferencesFieldNumber

```csharp
public const int ItemPreferencesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_ItemPreferences"></a> ItemPreferences

```csharp
public RepeatedField<CDOTAClientMsg_SuggestItemPreference.Types.ItemPreference> ItemPreferences { get; }
```

#### Property Value

 RepeatedField<[CDOTAClientMsg\_SuggestItemPreference](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemPreference.md).[Types](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemPreference.Types.md).[ItemPreference](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemPreference.Types.ItemPreference.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_SuggestItemPreference> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_SuggestItemPreference](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemPreference.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_SuggestItemPreference Clone()
```

#### Returns

 [CDOTAClientMsg\_SuggestItemPreference](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemPreference.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_"></a> Equals\(CDOTAClientMsg\_SuggestItemPreference\)

```csharp
public bool Equals(CDOTAClientMsg_SuggestItemPreference other)
```

#### Parameters

`other` [CDOTAClientMsg\_SuggestItemPreference](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemPreference.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_"></a> MergeFrom\(CDOTAClientMsg\_SuggestItemPreference\)

```csharp
public void MergeFrom(CDOTAClientMsg_SuggestItemPreference other)
```

#### Parameters

`other` [CDOTAClientMsg\_SuggestItemPreference](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemPreference.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

