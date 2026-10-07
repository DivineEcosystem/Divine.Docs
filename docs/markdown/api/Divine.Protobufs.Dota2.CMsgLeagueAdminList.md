# <a id="Divine_Protobufs_Dota2_CMsgLeagueAdminList"></a> Class CMsgLeagueAdminList

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLeagueAdminList : IMessage<CMsgLeagueAdminList>, IEquatable<CMsgLeagueAdminList>, IDeepCloneable<CMsgLeagueAdminList>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLeagueAdminList](Divine.Protobufs.Dota2.CMsgLeagueAdminList.md)

#### Implements

IMessage<CMsgLeagueAdminList\>, 
[IEquatable<CMsgLeagueAdminList\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLeagueAdminList\>, 
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
[EnumerableExtensions.In<CMsgLeagueAdminList\>\(CMsgLeagueAdminList, params CMsgLeagueAdminList\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLeagueAdminList__ctor"></a> CMsgLeagueAdminList\(\)

```csharp
public CMsgLeagueAdminList()
```

### <a id="Divine_Protobufs_Dota2_CMsgLeagueAdminList__ctor_Divine_Protobufs_Dota2_CMsgLeagueAdminList_"></a> CMsgLeagueAdminList\(CMsgLeagueAdminList\)

```csharp
public CMsgLeagueAdminList(CMsgLeagueAdminList other)
```

#### Parameters

`other` [CMsgLeagueAdminList](Divine.Protobufs.Dota2.CMsgLeagueAdminList.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgLeagueAdminList_AccountIdsFieldNumber"></a> AccountIdsFieldNumber

```csharp
public const int AccountIdsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLeagueAdminList_AccountIds"></a> AccountIds

```csharp
public RepeatedField<uint> AccountIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgLeagueAdminList_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLeagueAdminList_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLeagueAdminList> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLeagueAdminList](Divine.Protobufs.Dota2.CMsgLeagueAdminList.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLeagueAdminList_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueAdminList_Clone"></a> Clone\(\)

```csharp
public CMsgLeagueAdminList Clone()
```

#### Returns

 [CMsgLeagueAdminList](Divine.Protobufs.Dota2.CMsgLeagueAdminList.md)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueAdminList_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueAdminList_Equals_Divine_Protobufs_Dota2_CMsgLeagueAdminList_"></a> Equals\(CMsgLeagueAdminList\)

```csharp
public bool Equals(CMsgLeagueAdminList other)
```

#### Parameters

`other` [CMsgLeagueAdminList](Divine.Protobufs.Dota2.CMsgLeagueAdminList.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueAdminList_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueAdminList_MergeFrom_Divine_Protobufs_Dota2_CMsgLeagueAdminList_"></a> MergeFrom\(CMsgLeagueAdminList\)

```csharp
public void MergeFrom(CMsgLeagueAdminList other)
```

#### Parameters

`other` [CMsgLeagueAdminList](Divine.Protobufs.Dota2.CMsgLeagueAdminList.md)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueAdminList_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLeagueAdminList_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLeagueAdminList_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

