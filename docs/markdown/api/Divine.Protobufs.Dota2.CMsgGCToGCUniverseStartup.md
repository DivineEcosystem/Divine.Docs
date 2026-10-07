# <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartup"></a> Class CMsgGCToGCUniverseStartup

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCUniverseStartup : IMessage<CMsgGCToGCUniverseStartup>, IEquatable<CMsgGCToGCUniverseStartup>, IDeepCloneable<CMsgGCToGCUniverseStartup>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCUniverseStartup](Divine.Protobufs.Dota2.CMsgGCToGCUniverseStartup.md)

#### Implements

IMessage<CMsgGCToGCUniverseStartup\>, 
[IEquatable<CMsgGCToGCUniverseStartup\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCUniverseStartup\>, 
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
[EnumerableExtensions.In<CMsgGCToGCUniverseStartup\>\(CMsgGCToGCUniverseStartup, params CMsgGCToGCUniverseStartup\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartup__ctor"></a> CMsgGCToGCUniverseStartup\(\)

```csharp
public CMsgGCToGCUniverseStartup()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartup__ctor_Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartup_"></a> CMsgGCToGCUniverseStartup\(CMsgGCToGCUniverseStartup\)

```csharp
public CMsgGCToGCUniverseStartup(CMsgGCToGCUniverseStartup other)
```

#### Parameters

`other` [CMsgGCToGCUniverseStartup](Divine.Protobufs.Dota2.CMsgGCToGCUniverseStartup.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartup_IsInitialStartupFieldNumber"></a> IsInitialStartupFieldNumber

```csharp
public const int IsInitialStartupFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartup_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartup_HasIsInitialStartup"></a> HasIsInitialStartup

```csharp
public bool HasIsInitialStartup { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartup_IsInitialStartup"></a> IsInitialStartup

```csharp
public bool IsInitialStartup { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartup_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCUniverseStartup> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCUniverseStartup](Divine.Protobufs.Dota2.CMsgGCToGCUniverseStartup.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartup_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartup_ClearIsInitialStartup"></a> ClearIsInitialStartup\(\)

```csharp
public void ClearIsInitialStartup()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartup_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCUniverseStartup Clone()
```

#### Returns

 [CMsgGCToGCUniverseStartup](Divine.Protobufs.Dota2.CMsgGCToGCUniverseStartup.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartup_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartup_Equals_Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartup_"></a> Equals\(CMsgGCToGCUniverseStartup\)

```csharp
public bool Equals(CMsgGCToGCUniverseStartup other)
```

#### Parameters

`other` [CMsgGCToGCUniverseStartup](Divine.Protobufs.Dota2.CMsgGCToGCUniverseStartup.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartup_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartup_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartup_"></a> MergeFrom\(CMsgGCToGCUniverseStartup\)

```csharp
public void MergeFrom(CMsgGCToGCUniverseStartup other)
```

#### Parameters

`other` [CMsgGCToGCUniverseStartup](Divine.Protobufs.Dota2.CMsgGCToGCUniverseStartup.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartup_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartup_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUniverseStartup_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

