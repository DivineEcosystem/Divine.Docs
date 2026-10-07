# <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoList"></a> Class CMsgDOTALeagueInfoList

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALeagueInfoList : IMessage<CMsgDOTALeagueInfoList>, IEquatable<CMsgDOTALeagueInfoList>, IDeepCloneable<CMsgDOTALeagueInfoList>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALeagueInfoList](Divine.Protobufs.Dota2.CMsgDOTALeagueInfoList.md)

#### Implements

IMessage<CMsgDOTALeagueInfoList\>, 
[IEquatable<CMsgDOTALeagueInfoList\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALeagueInfoList\>, 
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
[EnumerableExtensions.In<CMsgDOTALeagueInfoList\>\(CMsgDOTALeagueInfoList, params CMsgDOTALeagueInfoList\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoList__ctor"></a> CMsgDOTALeagueInfoList\(\)

```csharp
public CMsgDOTALeagueInfoList()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoList__ctor_Divine_Protobufs_Dota2_CMsgDOTALeagueInfoList_"></a> CMsgDOTALeagueInfoList\(CMsgDOTALeagueInfoList\)

```csharp
public CMsgDOTALeagueInfoList(CMsgDOTALeagueInfoList other)
```

#### Parameters

`other` [CMsgDOTALeagueInfoList](Divine.Protobufs.Dota2.CMsgDOTALeagueInfoList.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoList_InfosFieldNumber"></a> InfosFieldNumber

```csharp
public const int InfosFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoList_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoList_Infos"></a> Infos

```csharp
public RepeatedField<CMsgDOTALeagueInfo> Infos { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTALeagueInfo](Divine.Protobufs.Dota2.CMsgDOTALeagueInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoList_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALeagueInfoList> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALeagueInfoList](Divine.Protobufs.Dota2.CMsgDOTALeagueInfoList.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoList_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoList_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALeagueInfoList Clone()
```

#### Returns

 [CMsgDOTALeagueInfoList](Divine.Protobufs.Dota2.CMsgDOTALeagueInfoList.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoList_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoList_Equals_Divine_Protobufs_Dota2_CMsgDOTALeagueInfoList_"></a> Equals\(CMsgDOTALeagueInfoList\)

```csharp
public bool Equals(CMsgDOTALeagueInfoList other)
```

#### Parameters

`other` [CMsgDOTALeagueInfoList](Divine.Protobufs.Dota2.CMsgDOTALeagueInfoList.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoList_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoList_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALeagueInfoList_"></a> MergeFrom\(CMsgDOTALeagueInfoList\)

```csharp
public void MergeFrom(CMsgDOTALeagueInfoList other)
```

#### Parameters

`other` [CMsgDOTALeagueInfoList](Divine.Protobufs.Dota2.CMsgDOTALeagueInfoList.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoList_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoList_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoList_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

