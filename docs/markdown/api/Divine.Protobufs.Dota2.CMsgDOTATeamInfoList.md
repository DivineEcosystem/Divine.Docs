# <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoList"></a> Class CMsgDOTATeamInfoList

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTATeamInfoList : IMessage<CMsgDOTATeamInfoList>, IEquatable<CMsgDOTATeamInfoList>, IDeepCloneable<CMsgDOTATeamInfoList>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTATeamInfoList](Divine.Protobufs.Dota2.CMsgDOTATeamInfoList.md)

#### Implements

IMessage<CMsgDOTATeamInfoList\>, 
[IEquatable<CMsgDOTATeamInfoList\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTATeamInfoList\>, 
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
[EnumerableExtensions.In<CMsgDOTATeamInfoList\>\(CMsgDOTATeamInfoList, params CMsgDOTATeamInfoList\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoList__ctor"></a> CMsgDOTATeamInfoList\(\)

```csharp
public CMsgDOTATeamInfoList()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoList__ctor_Divine_Protobufs_Dota2_CMsgDOTATeamInfoList_"></a> CMsgDOTATeamInfoList\(CMsgDOTATeamInfoList\)

```csharp
public CMsgDOTATeamInfoList(CMsgDOTATeamInfoList other)
```

#### Parameters

`other` [CMsgDOTATeamInfoList](Divine.Protobufs.Dota2.CMsgDOTATeamInfoList.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoList_TeamsFieldNumber"></a> TeamsFieldNumber

```csharp
public const int TeamsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoList_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoList_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTATeamInfoList> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTATeamInfoList](Divine.Protobufs.Dota2.CMsgDOTATeamInfoList.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoList_Teams"></a> Teams

```csharp
public RepeatedField<CMsgDOTATeamInfo> Teams { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoList_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoList_Clone"></a> Clone\(\)

```csharp
public CMsgDOTATeamInfoList Clone()
```

#### Returns

 [CMsgDOTATeamInfoList](Divine.Protobufs.Dota2.CMsgDOTATeamInfoList.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoList_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoList_Equals_Divine_Protobufs_Dota2_CMsgDOTATeamInfoList_"></a> Equals\(CMsgDOTATeamInfoList\)

```csharp
public bool Equals(CMsgDOTATeamInfoList other)
```

#### Parameters

`other` [CMsgDOTATeamInfoList](Divine.Protobufs.Dota2.CMsgDOTATeamInfoList.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoList_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoList_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTATeamInfoList_"></a> MergeFrom\(CMsgDOTATeamInfoList\)

```csharp
public void MergeFrom(CMsgDOTATeamInfoList other)
```

#### Parameters

`other` [CMsgDOTATeamInfoList](Divine.Protobufs.Dota2.CMsgDOTATeamInfoList.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoList_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoList_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfoList_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

