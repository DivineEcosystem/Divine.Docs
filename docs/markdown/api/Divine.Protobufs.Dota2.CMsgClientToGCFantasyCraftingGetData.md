# <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetData"></a> Class CMsgClientToGCFantasyCraftingGetData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCFantasyCraftingGetData : IMessage<CMsgClientToGCFantasyCraftingGetData>, IEquatable<CMsgClientToGCFantasyCraftingGetData>, IDeepCloneable<CMsgClientToGCFantasyCraftingGetData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCFantasyCraftingGetData](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGetData.md)

#### Implements

IMessage<CMsgClientToGCFantasyCraftingGetData\>, 
[IEquatable<CMsgClientToGCFantasyCraftingGetData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCFantasyCraftingGetData\>, 
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
[EnumerableExtensions.In<CMsgClientToGCFantasyCraftingGetData\>\(CMsgClientToGCFantasyCraftingGetData, params CMsgClientToGCFantasyCraftingGetData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetData__ctor"></a> CMsgClientToGCFantasyCraftingGetData\(\)

```csharp
public CMsgClientToGCFantasyCraftingGetData()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetData__ctor_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetData_"></a> CMsgClientToGCFantasyCraftingGetData\(CMsgClientToGCFantasyCraftingGetData\)

```csharp
public CMsgClientToGCFantasyCraftingGetData(CMsgClientToGCFantasyCraftingGetData other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingGetData](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGetData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetData_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetData_FantasyLeagueFieldNumber"></a> FantasyLeagueFieldNumber

```csharp
public const int FantasyLeagueFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetData_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetData_FantasyLeague"></a> FantasyLeague

```csharp
public uint FantasyLeague { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetData_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetData_HasFantasyLeague"></a> HasFantasyLeague

```csharp
public bool HasFantasyLeague { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCFantasyCraftingGetData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCFantasyCraftingGetData](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGetData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetData_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetData_ClearFantasyLeague"></a> ClearFantasyLeague\(\)

```csharp
public void ClearFantasyLeague()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetData_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCFantasyCraftingGetData Clone()
```

#### Returns

 [CMsgClientToGCFantasyCraftingGetData](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGetData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetData_Equals_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetData_"></a> Equals\(CMsgClientToGCFantasyCraftingGetData\)

```csharp
public bool Equals(CMsgClientToGCFantasyCraftingGetData other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingGetData](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGetData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetData_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetData_"></a> MergeFrom\(CMsgClientToGCFantasyCraftingGetData\)

```csharp
public void MergeFrom(CMsgClientToGCFantasyCraftingGetData other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingGetData](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGetData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

